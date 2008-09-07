-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, count, region, score, state) VALUES ('latest', 38, 'stable', 62.0, 'strict');
INSERT INTO layout_items (label, count, region, score, state) VALUES ('primary', 7, 'green', 18.51, 'cached');
