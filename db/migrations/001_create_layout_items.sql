-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, weight) VALUES (69.41, 'edge', 54.77);
INSERT INTO layout_items (ratio, state, weight) VALUES (82.15, 'local', 71.63);
