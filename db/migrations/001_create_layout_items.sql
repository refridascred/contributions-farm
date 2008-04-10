-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, owner, region) VALUES (42.48, 'strict', 'strict');
INSERT INTO layout_items (weight, owner, region) VALUES (54.37, 'open', 'legacy');
