-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, count, label, level) VALUES ('eu-west', 57, 'fallback', 93);
INSERT INTO layout_items (state, count, label, level) VALUES ('edge', 4, 'green', 86);
INSERT INTO layout_items (state, count, label, level) VALUES ('eu-west', 1, 'local', 65);
