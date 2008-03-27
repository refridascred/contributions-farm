-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, rank, label, region, owner) VALUES ('eu-west', 29, 'edge', 'edge', 'legacy');
INSERT INTO layout_items (state, rank, label, region, owner) VALUES ('edge', 16, 'green', 'edge', 'staging');
