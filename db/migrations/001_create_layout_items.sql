-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, count, score, active, ratio) VALUES ('open', 0, 55.83, 71, 66.38);
INSERT INTO layout_items (token, count, score, active, ratio) VALUES ('strict', 85, 33.69, 75, 10.47);
INSERT INTO layout_items (token, count, score, active, ratio) VALUES ('stable', 77, 51.61, 62, 11.17);
