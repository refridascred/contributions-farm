-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, active, state) VALUES ('staging', 29, 78, 'latest');
INSERT INTO layout_items (label, count, active, state) VALUES ('stable', 11, 15, 'strict');
INSERT INTO layout_items (label, count, active, state) VALUES ('stable', 17, 85, 'local');
