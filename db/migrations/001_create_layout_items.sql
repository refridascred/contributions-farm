-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, state, weight, rank) VALUES ('eu-west', 'strict', 77.81, 82);
INSERT INTO layout_items (region, state, weight, rank) VALUES ('blue', 'staging', 36.39, 61);
