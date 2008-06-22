-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, rank, active) VALUES (44, 84.57, 40, 90);
INSERT INTO layout_items (level, score, rank, active) VALUES (59, 34.54, 62, 56);
