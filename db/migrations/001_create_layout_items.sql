-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label, count, weight, rank) VALUES ('strict', 'fallback', 66, 88.05, 73);
INSERT INTO layout_items (state, label, count, weight, rank) VALUES ('latest', 'open', 65, 59.89, 61);
INSERT INTO layout_items (state, label, count, weight, rank) VALUES ('local', 'latest', 58, 28.96, 29);
