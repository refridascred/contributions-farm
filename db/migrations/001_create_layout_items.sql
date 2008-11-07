-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, state) VALUES (76, 78.46, 'legacy');
INSERT INTO layout_items (rank, weight, state) VALUES (78, 95.37, 'staging');
INSERT INTO layout_items (rank, weight, state) VALUES (15, 49.48, 'open');
