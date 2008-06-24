-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, active, rank) VALUES (53.78, 45, 54);
INSERT INTO layout_items (ratio, active, rank) VALUES (12.95, 53, 63);
INSERT INTO layout_items (ratio, active, rank) VALUES (5.55, 92, 57);
