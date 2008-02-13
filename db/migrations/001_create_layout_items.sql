-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, rank, level) VALUES ('eu-west', 77.88, 50, 98);
INSERT INTO layout_items (label, score, rank, level) VALUES ('open', 71.11, 20, 77);
INSERT INTO layout_items (label, score, rank, level) VALUES ('fallback', 11.67, 67, 22);
