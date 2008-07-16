-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, score, ratio, level) VALUES ('latest', 2.81, 25.94, 17);
INSERT INTO layout_items (token, score, ratio, level) VALUES ('strict', 13.7, 20.73, 42);
