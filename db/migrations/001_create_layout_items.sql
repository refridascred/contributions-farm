-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, weight, rank, level) VALUES ('stable', 10.54, 42, 58);
INSERT INTO layout_items (state, weight, rank, level) VALUES ('stable', 93.01, 66, 81);
INSERT INTO layout_items (state, weight, rank, level) VALUES ('standard', 21.48, 26, 61);
