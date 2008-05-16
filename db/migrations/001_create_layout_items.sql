-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, region, token, active) VALUES (80, 0.46, 'blue', 'standard', 86);
INSERT INTO layout_items (rank, weight, region, token, active) VALUES (89, 73.47, 'green', 'latest', 18);
INSERT INTO layout_items (rank, weight, region, token, active) VALUES (18, 18.12, 'local', 'staging', 40);
