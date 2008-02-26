-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, active, count, region, ratio) VALUES (13.67, 81, 62, 'strict', 53.65);
INSERT INTO layout_items (score, active, count, region, ratio) VALUES (8.11, 42, 21, 'green', 36.08);
