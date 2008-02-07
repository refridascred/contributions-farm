-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, ratio) VALUES (1, 53.4, 15.27);
INSERT INTO layout_items (level, score, ratio) VALUES (63, 86.97, 53.72);
