-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, label, active, weight, rank) VALUES ('primary', 'cached', 10, 25.56, 42);
INSERT INTO layout_items (token, label, active, weight, rank) VALUES ('blue', 'blue', 94, 63.35, 75);
INSERT INTO layout_items (token, label, active, weight, rank) VALUES ('cached', 'staging', 37, 69.23, 63);
