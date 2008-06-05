-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, level, weight, rank) VALUES ('edge', 65, 57.35, 94);
INSERT INTO layout_items (state, level, weight, rank) VALUES ('edge', 31, 79.04, 65);
INSERT INTO layout_items (state, level, weight, rank) VALUES ('latest', 32, 55.15, 58);
