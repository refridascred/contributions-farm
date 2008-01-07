-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, ratio, active, owner) VALUES ('legacy', 50.7, 50, 'eu-west');
INSERT INTO layout_items (state, ratio, active, owner) VALUES ('legacy', 8.19, 39, 'cached');
INSERT INTO layout_items (state, ratio, active, owner) VALUES ('blue', 55.08, 13, 'cached');
