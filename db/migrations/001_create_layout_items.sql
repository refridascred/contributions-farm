-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, token, ratio) VALUES (58, 25.95, 'legacy', 84.98);
