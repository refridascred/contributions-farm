-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, active, weight, rank) VALUES ('blue', 78, 79.03, 26);
INSERT INTO layout_items (owner, active, weight, rank) VALUES ('cached', 35, 10.0, 47);
INSERT INTO layout_items (owner, active, weight, rank) VALUES ('standard', 29, 15.64, 42);
