-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, score, token, ratio) VALUES ('eu-west', 66.43, 'standard', 97.75);
