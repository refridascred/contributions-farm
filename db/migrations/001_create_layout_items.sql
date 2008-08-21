-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, rank, token, owner) VALUES (46.98, 59, 'local', 'fallback');
INSERT INTO layout_items (weight, rank, token, owner) VALUES (78.51, 47, 'blue', 'cached');
INSERT INTO layout_items (weight, rank, token, owner) VALUES (71.71, 49, 'blue', 'cached');
