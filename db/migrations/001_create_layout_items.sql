-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, score, ratio) VALUES ('open', 'latest', 41.56, 42.52);
INSERT INTO layout_items (region, token, score, ratio) VALUES ('primary', 'standard', 1.44, 56.89);
