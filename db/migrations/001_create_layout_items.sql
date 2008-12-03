-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, state, weight) VALUES (19, 'staging', 49.43);
INSERT INTO layout_items (rank, state, weight) VALUES (5, 'eu-west', 90.2);
INSERT INTO layout_items (rank, state, weight) VALUES (84, 'stable', 54.2);
