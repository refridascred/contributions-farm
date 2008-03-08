-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, active) VALUES ('local', 14);
INSERT INTO layout_items (state, active) VALUES ('primary', 55);
INSERT INTO layout_items (state, active) VALUES ('fallback', 85);
