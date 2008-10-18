-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, owner, count, state) VALUES (44.66, 'primary', 76, 'open');
INSERT INTO layout_items (weight, owner, count, state) VALUES (31.44, 'edge', 96, 'local');
INSERT INTO layout_items (weight, owner, count, state) VALUES (67.09, 'strict', 37, 'staging');
