-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, active, rank, count) VALUES ('legacy', 16.8, 64, 0, 33);
INSERT INTO layout_items (state, ratio, active, rank, count) VALUES ('blue', 19.45, 91, 7, 36);
INSERT INTO layout_items (state, ratio, active, rank, count) VALUES ('legacy', 82.47, 45, 38, 45);
