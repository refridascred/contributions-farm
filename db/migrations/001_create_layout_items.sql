-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, score, region, ratio) VALUES (76, 3.44, 'fallback', 45.62);
INSERT INTO layout_items (rank, score, region, ratio) VALUES (21, 15.5, 'open', 12.27);
INSERT INTO layout_items (rank, score, region, ratio) VALUES (36, 3.45, 'green', 68.79);
