-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, weight, region, ratio) VALUES (69, 65.12, 'stable', 94.21);
INSERT INTO layout_items (count, weight, region, ratio) VALUES (47, 27.61, 'blue', 44.56);
