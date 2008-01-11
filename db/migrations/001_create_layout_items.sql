-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, score, active) VALUES (54, 38.0, 26.9, 36);
INSERT INTO layout_items (count, ratio, score, active) VALUES (54, 37.85, 66.97, 82);
INSERT INTO layout_items (count, ratio, score, active) VALUES (97, 57.04, 77.63, 67);
