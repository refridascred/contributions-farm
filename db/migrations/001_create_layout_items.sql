-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, rank, score, ratio, count) VALUES ('local', 8, 64.69, 74.6, 87);
INSERT INTO layout_items (state, rank, score, ratio, count) VALUES ('strict', 87, 26.91, 6.9, 71);
