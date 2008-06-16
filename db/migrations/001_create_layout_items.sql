-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, level, state, weight) VALUES (87, 96, 'green', 87.13);
INSERT INTO layout_items (rank, level, state, weight) VALUES (95, 8, 'legacy', 30.26);
INSERT INTO layout_items (rank, level, state, weight) VALUES (25, 32, 'staging', 82.22);
