-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, state, ratio, label, rank) VALUES ('latest', 'stable', 79.52, 'staging', 98);
INSERT INTO layout_items (region, state, ratio, label, rank) VALUES ('edge', 'staging', 39.79, 'primary', 17);
INSERT INTO layout_items (region, state, ratio, label, rank) VALUES ('primary', 'stable', 7.48, 'strict', 88);
