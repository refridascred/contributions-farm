-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, token) VALUES ('staging', 90.97, 'local');
INSERT INTO layout_items (owner, weight, token) VALUES ('primary', 77.67, 'strict');
INSERT INTO layout_items (owner, weight, token) VALUES ('local', 89.4, 'edge');
