-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, ratio, owner) VALUES ('edge', 52.11, 'eu-west');
INSERT INTO layout_items (state, ratio, owner) VALUES ('green', 77.4, 'cached');
INSERT INTO layout_items (state, ratio, owner) VALUES ('blue', 52.45, 'latest');
