-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, weight, region, count) VALUES ('latest', 63.84, 'latest', 6);
INSERT INTO layout_items (owner, weight, region, count) VALUES ('stable', 90.76, 'fallback', 92);
