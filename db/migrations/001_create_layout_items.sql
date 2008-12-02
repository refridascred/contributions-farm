-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, score, count, ratio) VALUES ('legacy', 18.84, 87, 19.57);
INSERT INTO layout_items (label, score, count, ratio) VALUES ('staging', 23.72, 93, 82.97);
