-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, count) VALUES ('fallback', 'latest', 90);
INSERT INTO layout_items (owner, state, count) VALUES ('eu-west', 'primary', 79);
INSERT INTO layout_items (owner, state, count) VALUES ('edge', 'standard', 31);
