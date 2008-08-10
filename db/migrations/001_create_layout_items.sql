-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, rank, owner, count) VALUES ('primary', 31, 'edge', 49);
INSERT INTO layout_items (label, rank, owner, count) VALUES ('latest', 57, 'standard', 45);
INSERT INTO layout_items (label, rank, owner, count) VALUES ('cached', 73, 'legacy', 23);
