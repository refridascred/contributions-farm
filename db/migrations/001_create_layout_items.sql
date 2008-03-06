-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, rank, label) VALUES (85, 61, 'standard');
INSERT INTO layout_items (count, rank, label) VALUES (47, 22, 'legacy');
INSERT INTO layout_items (count, rank, label) VALUES (40, 53, 'staging');
