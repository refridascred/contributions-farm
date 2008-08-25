-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, region, active, weight, rank) VALUES ('local', 'open', 30, 78.41, 2);
INSERT INTO layout_items (state, region, active, weight, rank) VALUES ('open', 'standard', 29, 66.18, 48);
