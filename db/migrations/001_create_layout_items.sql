-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, label, region, token) VALUES (30.42, 'stable', 'fallback', 'staging');
INSERT INTO layout_items (weight, label, region, token) VALUES (42.51, 'open', 'stable', 'blue');
INSERT INTO layout_items (weight, label, region, token) VALUES (27.45, 'staging', 'edge', 'blue');
