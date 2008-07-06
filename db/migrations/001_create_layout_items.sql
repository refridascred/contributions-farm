-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, weight, token) VALUES (87, 76.71, 'fallback');
INSERT INTO layout_items (active, weight, token) VALUES (45, 62.6, 'local');
INSERT INTO layout_items (active, weight, token) VALUES (28, 59.67, 'edge');
