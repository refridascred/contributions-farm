-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, owner, ratio, rank) VALUES ('edge', 'stable', 1.3, 63);
INSERT INTO layout_items (region, owner, ratio, rank) VALUES ('latest', 'fallback', 55.72, 56);
