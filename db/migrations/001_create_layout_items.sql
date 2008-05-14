-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, token) VALUES ('cached', 72.87, 'standard');
INSERT INTO layout_items (label, weight, token) VALUES ('staging', 79.64, 'latest');
INSERT INTO layout_items (label, weight, token) VALUES ('legacy', 35.41, 'strict');
