-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, level) VALUES (97.81, 48.66, 3);
INSERT INTO layout_items (score, ratio, level) VALUES (38.66, 60.58, 97);
INSERT INTO layout_items (score, ratio, level) VALUES (21.49, 17.27, 27);
