-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, score, label, level, rank) VALUES (96, 89.02, 'legacy', 48, 88);
INSERT INTO layout_items (count, score, label, level, rank) VALUES (75, 72.89, 'blue', 18, 87);
