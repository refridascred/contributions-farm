-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, token, region) VALUES (64, 74.37, 'staging', 'open');
