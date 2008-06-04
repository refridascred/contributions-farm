-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, count, rank, ratio, weight) VALUES ('latest', 39, 63, 85.51, 64.79);
INSERT INTO layout_items (state, count, rank, ratio, weight) VALUES ('fallback', 16, 51, 74.92, 67.11);
INSERT INTO layout_items (state, count, rank, ratio, weight) VALUES ('stable', 63, 37, 19.82, 84.77);
