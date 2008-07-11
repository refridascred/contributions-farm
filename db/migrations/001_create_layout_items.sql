-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, label, state, rank) VALUES ('latest', 'green', 'blue', 5);
INSERT INTO layout_items (region, label, state, rank) VALUES ('blue', 'staging', 'strict', 98);
