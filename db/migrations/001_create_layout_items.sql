-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, label, level, active) VALUES ('open', 'primary', 10, 26);
INSERT INTO layout_items (state, label, level, active) VALUES ('legacy', 'staging', 43, 89);
INSERT INTO layout_items (state, label, level, active) VALUES ('legacy', 'edge', 77, 75);
