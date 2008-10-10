-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, score, level) VALUES (19.23, 'blue', 46.26, 66);
INSERT INTO layout_items (ratio, label, score, level) VALUES (11.76, 'edge', 78.22, 52);
