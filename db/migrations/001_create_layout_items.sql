-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, active, rank, token) VALUES (77.37, 45, 5, 'legacy');
INSERT INTO layout_items (weight, active, rank, token) VALUES (55.65, 33, 67, 'standard');
INSERT INTO layout_items (weight, active, rank, token) VALUES (45.99, 41, 84, 'primary');
