-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, ratio, level, score) VALUES ('standard', 26.33, 41, 22.27);
INSERT INTO layout_items (token, ratio, level, score) VALUES ('edge', 15.92, 72, 76.94);
