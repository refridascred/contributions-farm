-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, ratio, rank) VALUES ('latest', 'fallback', 34.72, 75);
INSERT INTO layout_items (label, state, ratio, rank) VALUES ('primary', 'green', 19.59, 62);
INSERT INTO layout_items (label, state, ratio, rank) VALUES ('edge', 'strict', 52.01, 96);
