-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, rank, token, score, level) VALUES ('strict', 19, 'stable', 94.98, 6);
INSERT INTO layout_items (label, rank, token, score, level) VALUES ('cached', 74, 'standard', 35.23, 30);
INSERT INTO layout_items (label, rank, token, score, level) VALUES ('edge', 20, 'open', 14.31, 77);
