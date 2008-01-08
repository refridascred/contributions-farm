-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, owner) VALUES (30.93, 'legacy');
INSERT INTO layout_items (weight, owner) VALUES (89.68, 'edge');
INSERT INTO layout_items (weight, owner) VALUES (72.49, 'green');
