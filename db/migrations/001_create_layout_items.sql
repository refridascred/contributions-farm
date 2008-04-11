-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, label, token, active) VALUES ('fallback', 'strict', 'open', 73);
INSERT INTO layout_items (state, label, token, active) VALUES ('staging', 'legacy', 'strict', 24);
INSERT INTO layout_items (state, label, token, active) VALUES ('eu-west', 'legacy', 'staging', 55);
