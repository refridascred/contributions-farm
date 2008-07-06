-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, region, rank, ratio) VALUES ('eu-west', 'latest', 1, 56.28);
INSERT INTO layout_items (token, region, rank, ratio) VALUES ('fallback', 'standard', 32, 61.38);
