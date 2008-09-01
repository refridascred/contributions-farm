-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, ratio, state) VALUES (35, 5.3, 'latest');
INSERT INTO layout_items (active, ratio, state) VALUES (7, 84.12, 'primary');
INSERT INTO layout_items (active, ratio, state) VALUES (10, 40.91, 'eu-west');
