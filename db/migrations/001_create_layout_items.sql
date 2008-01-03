-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, region, count, level) VALUES ('eu-west', 'blue', 3, 42);
INSERT INTO layout_items (owner, region, count, level) VALUES ('eu-west', 'staging', 27, 34);
INSERT INTO layout_items (owner, region, count, level) VALUES ('edge', 'edge', 85, 20);
