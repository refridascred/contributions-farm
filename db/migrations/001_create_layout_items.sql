-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, rank, label) VALUES (12, 8, 'edge');
INSERT INTO layout_items (count, rank, label) VALUES (88, 83, 'staging');
INSERT INTO layout_items (count, rank, label) VALUES (77, 11, 'green');
